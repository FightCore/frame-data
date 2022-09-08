import { FrameDataCharacter } from 'src/app/models/framedata-character';
import * as FrameDataActions from './frame-data.actions';
import { Action, createReducer, on } from '@ngrx/store';
import { Move } from 'src/app/models/move';

export const featureKey = 'frameData';

export interface FrameDataState {
  characters: FrameDataCharacter[];
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
    for (const movesArray of mappedMoves) {
      for (const move of movesArray.moves) {
        moves.push({
          ...move,
          character: movesArray.character,
          characterId: movesArray.character.fightCoreId,
        });
      }
    }
    return { characters: [...characters], moves: [...moves] };
  })
);
