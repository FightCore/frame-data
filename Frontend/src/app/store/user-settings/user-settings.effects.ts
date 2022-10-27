import { isPlatformBrowser } from '@angular/common';
import { Inject, Injectable, PLATFORM_ID } from '@angular/core';
import { makeStateKey, StateKey, TransferState } from '@angular/platform-browser';
import { Actions, createEffect, ofType } from '@ngrx/effects';
import { mergeMap, of, tap } from 'rxjs';
import { loadedSettings, loadSettings, updateTheme } from './user-settings.actions';

@Injectable()
export class UserSettingsEffects {
  constructor(
    private actions$: Actions,
    @Inject(PLATFORM_ID) private platformId: any,
    private transferState: TransferState
  ) {}
  stateKey: StateKey<boolean> = makeStateKey<boolean>('UseDarkMode');
  loadUserSettings$ = createEffect(() =>
    this.actions$.pipe(
      ofType(loadSettings),
      mergeMap(() => {
        // Check if we have something stored.
        if (this.transferState.hasKey(this.stateKey)) {
          return of(loadedSettings(this.transferState.get(this.stateKey, true)));
        }
        // If there is nothing stored and we are on the browser, return the default true value.
        if (isPlatformBrowser(this.platformId)) {
          return of(loadedSettings(true));
        }
        const useDarkMode = localStorage.getItem('Theme:UseDarkMode');
        if (useDarkMode) {
          return of(loadedSettings(JSON.parse(useDarkMode) as boolean)).pipe(
            tap((darkMode) => this.transferState.set(this.stateKey, darkMode.useDarkMode))
          );
        }

        return of(loadedSettings(true)).pipe(
          tap((darkMode) => this.transferState.set(this.stateKey, darkMode.useDarkMode))
        );
      })
    )
  );
}
