import { Injectable, makeStateKey, StateKey, TransferState } from '@angular/core';

import { Actions, concatLatestFrom, createEffect, ofType } from '@ngrx/effects';
import { exhaustMap, filter, first, map, merge, mergeMap, of, tap, withLatestFrom } from 'rxjs';
import { FrameDataService } from 'src/app/services/frame-data.service';
import * as FrameDataActions from './frame-data.actions';
import { ExtendedCharacter } from 'src/app/models/extended-character';
import { select, Store } from '@ngrx/store';
import { selectCharacters } from './frame-data.selectors';

@Injectable()
export class FrameDataEffects {
  constructor(
    private actions$: Actions,
    private frameDataService: FrameDataService,
    private transferState: TransferState,
    private store: Store
  ) {}
  stateKey: StateKey<ExtendedCharacter[]> = makeStateKey<ExtendedCharacter[]>('moves');
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
  loadCharacterData$ = createEffect(() =>
    this.actions$.pipe(
      ofType(FrameDataActions.expandCharacter),
      exhaustMap((action) => {
        return this.store.pipe(
          select(selectCharacters()),
          first((characters) => characters != null && characters.length > 0),
          map(
            (characters) => characters.find((character) => character.fightCoreId === action.fightCoreId)?.normalizedName
          ),
          mergeMap((normalizedName) =>
            this.frameDataService
              .getMovesForCharacter(normalizedName!)
              .pipe(map((character) => FrameDataActions.loadExpandedCharacter(character)))
          )
        );
      })
    )
  );
}
