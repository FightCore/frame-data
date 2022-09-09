import { createFeatureSelector, createSelector } from '@ngrx/store';
import { FrameDataState, featureKey } from './frame-data.reducers';

export const selectCharactersState = createFeatureSelector<FrameDataState>(featureKey);

export const selectCharacters = () =>
  createSelector(selectCharactersState, (state: FrameDataState) => state.characters);

export const selectCharacter = (props: { characterId: number }) =>
  createSelector(selectCharactersState, (state: FrameDataState) =>
    state.characters.find((character) => character.fightCoreId === props.characterId)
  );

export const selectMoves = () => createSelector(selectCharactersState, (state: FrameDataState) => state.moves);

export const selectMove = (props: { characterId: number; moveId: number }) =>
  createSelector(selectCharactersState, (state: FrameDataState) =>
    state.moves.find((move) => move.characterId === props.characterId && move.id === props.moveId)
  );
