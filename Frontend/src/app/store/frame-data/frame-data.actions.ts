import { Character } from '@fightcore/models';
import { createAction, props } from '@ngrx/store';
import { ExtendedCharacter } from 'src/app/models/extended-character';

export const loadCharacters = createAction('[Frame Data] Load Characters');

export const loadedCharacters = createAction('[Frame Data] Loaded Characters', (characters: ExtendedCharacter[]) => ({
  characters,
}));
