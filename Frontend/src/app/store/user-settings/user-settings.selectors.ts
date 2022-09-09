import { createFeatureSelector, createSelector } from '@ngrx/store';
import { featureKey, UserSettingsState } from './user-settings.reducers';

export const selectUserSettingsState = createFeatureSelector<UserSettingsState>(featureKey);

export const isDarkMode = () =>
  createSelector(selectUserSettingsState, (state: UserSettingsState) => state.useDarkTheme);
