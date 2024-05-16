import { Character } from '@fightcore/models';
import { createAction, props } from '@ngrx/store';
import { create } from 'node:domain';
import { ExtendedCharacter } from 'src/app/models/extended-character';

export const loadCharacters = createAction('[Frame Data] Load Characters');

export const expandCharacter = createAction('[Frame Data] Expand Character', props<{ fightCoreId: number }>());
export const loadExpandedCharacter = createAction(
  '[Frame Data] Load Expanded Chracter',
  (character: ExtendedCharacter) => ({ character })
);

export const loadedCharacters = createAction('[Frame Data] Loaded Characters', (characters: ExtendedCharacter[]) => ({
  characters,
}));
