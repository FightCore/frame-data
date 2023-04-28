import { Character } from '@fightcore/models';
import { createAction, props } from '@ngrx/store';

export const loadCharacters = createAction('[Frame Data] Load Characters');

export const loadedCharacters = createAction('[Frame Data] Loaded Characters', (characters: Character[]) => ({
  characters,
}));
