import { Character, Move } from '@fightcore/models';
import * as FrameDataActions from './frame-data.actions';
import { Action, createReducer, on } from '@ngrx/store';
import { ExtendedCharacter } from 'src/app/models/extended-character';

export const featureKey = 'frameData';

export interface FrameDataState {
  characters: ExtendedCharacter[];
  moves: Move[];
}
export const initialState: FrameDataState = {
  characters: [],
  moves: [],
};

export const frameDataReducer = createReducer(
  initialState,
  on(FrameDataActions.loadedCharacters, (_state, { characters }) => {
    const moves = [];
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
    return { characters: [...characters], moves: [] }; //moves: [...moves] };
  })
);
