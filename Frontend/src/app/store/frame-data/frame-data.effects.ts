import { Injectable } from '@angular/core';
import { makeStateKey, StateKey, TransferState } from '@angular/platform-browser';
import { Actions, createEffect, ofType } from '@ngrx/effects';
import { map, mergeMap, of, tap } from 'rxjs';
import { FrameDataCharacter } from 'src/app/models/framedata-character';
import { FrameDataService } from 'src/app/services/frame-data.service';
import * as FrameDataActions from './frame-data.actions';

@Injectable()
export class FrameDataEffects {
  constructor(
    private actions$: Actions,
    private frameDataService: FrameDataService,
    private transferState: TransferState
  ) {}
  stateKey: StateKey<FrameDataCharacter[]> = makeStateKey<FrameDataCharacter[]>('moves');
  loadFrameData$ = createEffect(() =>
    this.actions$.pipe(
      ofType(FrameDataActions.loadCharacters),
      mergeMap(() => {
        if (this.transferState.hasKey(this.stateKey)) {
          return of(FrameDataActions.loadedCharacters(this.transferState.get(this.stateKey, [])));
        }
        return this.frameDataService.getMoves().pipe(
          tap((characters) => this.transferState.set(this.stateKey, characters)),
          map((characters) => FrameDataActions.loadedCharacters(characters))
        );
      })
    )
  );
}
