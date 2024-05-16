import { Character, Move } from '@fightcore/models';
import * as FrameDataActions from './frame-data.actions';
import { Action, createReducer, on } from '@ngrx/store';
import { ExtendedCharacter } from 'src/app/models/extended-character';

export const featureKey = 'frameData';

export interface FrameDataState {
  characters: ExtendedCharacter[];
  moves: Move[];
  extendedCharacters: ExtendedCharacter[];
}
export const initialState: FrameDataState = {
  characters: [],
  moves: [],
  extendedCharacters: [],
};

export const frameDataReducer = createReducer(
  initialState,
  on(FrameDataActions.loadedCharacters, (_state, { characters }) => {
    const moves: Move[] = [];
    const mappedMoves = characters.map((character) => {
      return { moves: character.moves, character: character };
    });
    // for (const movesArray of mappedMoves) {
    //   for (const move of movesArray.moves) {
    //     moves.push({
    //       ...move,
    //       character: movesArray.character,
    //       characterId: movesArray.character.fightCoreId,
    //     });
    //   }
    // }
    return { characters: [...characters], moves: [...moves], extendedCharacters: [] };
  }),
  on(FrameDataActions.loadExpandedCharacter, (state, { character }) => {
    const newCharacters = [...state.extendedCharacters];
    const existing = newCharacters.findIndex((oldCharacter) => oldCharacter.fightCoreId === character.fightCoreId);
    if (existing !== -1) {
      return state;
    }

    newCharacters.push(character);

    return { characters: [...state.characters], moves: [...state.moves], extendedCharacters: newCharacters };
  })
);
