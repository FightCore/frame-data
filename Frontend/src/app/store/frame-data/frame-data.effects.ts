import { Injectable } from '@angular/core';
import { Actions, createEffect, ofType } from '@ngrx/effects';
import { catchError, EMPTY, map, mergeMap, tap } from 'rxjs';
import { FrameDataService } from 'src/app/services/frame-data.service';
import * as FrameDataActions from './frame-data.actions';

@Injectable()
export class FrameDataEffects {
  constructor(
    private actions$: Actions,
    private frameDataService: FrameDataService
  ) {}

  loadFrameData$ = createEffect(() =>
    this.actions$.pipe(
      ofType(FrameDataActions.loadCharacters),
      mergeMap(() =>
        this.frameDataService.getMoves().pipe(
          tap(() => console.log('Characters load called.')),
          map((characters) => {
            console.log('Characters', characters);
            return FrameDataActions.loadedCharacters(characters);
          })
        )
      )
    )
  );
}
