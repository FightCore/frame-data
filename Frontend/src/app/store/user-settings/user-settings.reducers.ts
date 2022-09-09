import { createReducer, on } from '@ngrx/store';
import { loadedSettings, updateTheme } from './user-settings.actions';

export const featureKey = 'userSettings';

export interface UserSettingsState {
  useDarkTheme: boolean;
}
export const initialState: UserSettingsState = {
  useDarkTheme: false,
};

export const userSettingsReducer = createReducer(
  initialState,
  on(loadedSettings, (_state, { useDarkMode }) => {
    return { useDarkTheme: useDarkMode };
  }),
  on(updateTheme, (_state, { useDarkMode }) => {
    localStorage.setItem('Theme:UseDarkMode', useDarkMode.toString());
    return { useDarkTheme: useDarkMode };
  })
);
