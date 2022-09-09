import { Injectable } from '@angular/core';
import { Actions, createEffect, ofType } from '@ngrx/effects';
import { mergeMap, of } from 'rxjs';
import { loadedSettings, loadSettings } from './user-settings.actions';

@Injectable()
export class UserSettingsEffects {
  constructor(private actions$: Actions) {}
  loadUserSettings$ = createEffect(() =>
    this.actions$.pipe(
      ofType(loadSettings),
      mergeMap(() => {
        const useDarkMode = localStorage.getItem('Theme:UseDarkMode');
        if (useDarkMode) {
          return of(loadedSettings(JSON.parse(useDarkMode) as boolean));
        }

        return of(loadedSettings(true));
      })
    )
  );
}
