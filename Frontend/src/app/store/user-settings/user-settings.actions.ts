import { createAction } from '@ngrx/store';

export const loadSettings = createAction('[User Settings] Load Settings');

export const loadedSettings = createAction('[User Settings] Loaded Settings', (useDarkMode: boolean) => ({
  useDarkMode: useDarkMode,
}));

export const updateTheme = createAction('[User Settings] Update Theme', (useDarkMode: boolean) => ({
  useDarkMode: useDarkMode,
}));
