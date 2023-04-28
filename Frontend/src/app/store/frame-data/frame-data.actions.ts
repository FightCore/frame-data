import { createAction, props } from '@ngrx/store';
import { Character } from 'src/app/models/character';

export const loadCharacters = createAction('[Frame Data] Load Characters');

export const loadedCharacters = createAction('[Frame Data] Loaded Characters', (characters: Character[]) => ({
  characters,
}));
