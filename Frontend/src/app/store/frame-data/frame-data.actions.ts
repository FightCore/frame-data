import { createAction, props } from '@ngrx/store';
import { FrameDataCharacter } from 'src/app/models/framedata-character';

export const loadCharacters = createAction('[Frame Data] Load Characters');

export const loadedCharacters = createAction(
  '[Frame Data] Loaded Characters',
  (characters: FrameDataCharacter[]) => ({ characters })
);
