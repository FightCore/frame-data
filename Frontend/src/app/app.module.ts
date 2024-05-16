import { NgModule } from '@angular/core';
import { BrowserModule, provideClientHydration } from '@angular/platform-browser';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { TranslateModule } from '@ngx-translate/core';
import { HttpClientModule } from '@angular/common/http';
import { SharedModule } from './modules/shared-module/shared.module';
import { MenubarComponent } from './components/layout/menubar/menubar.component';
import { FooterComponent } from './components/layout/footer/footer.component';
import { MoveCardComponent } from './components/moves/move-card/move-card.component';
import { CharacterPreviewCardComponent } from './components/characters/character-preview-card/character-preview-card.component';
import { CharacterStatisticsComponent } from './components/characters/character-statistics/character-statistics.component';
import { CharactersComponent } from './components/characters/characters/characters.component';
import { CharacterComponent } from './components/characters/character/character.component';
import { MoveListComponent } from './components/moves/move-list/move-list.component';
import { MovesTableComponent } from './components/moves/moves-table/moves-table.component';
import { CharacterStatisticsTableComponent } from './components/characters/character-statistics-table/character-statistics-table.component';
import { MoveAttributesListComponent } from './components/moves/move-attributes-list/move-attributes-list.component';
import { CharacterQuickPickerComponent } from './components/characters/character-quick-picker/character-quick-picker.component';
import { MoveComponent } from './components/moves/move/move.component';
import { MoveAttributesTableComponent } from './components/moves/move-attributes-table/move-attributes-table.component';
import { HitboxesTableComponent } from './components/hitboxes/hitboxes-table/hitboxes-table.component';
import { MoveGifComponent } from './components/moves/move-gif/move-gif.component';
import { StoreModule } from '@ngrx/store';
import { frameDataReducer } from './store/frame-data/frame-data.reducers';
import { FrameDataEffects } from './store/frame-data/frame-data.effects';
import { EffectsModule } from '@ngrx/effects';
import { MovesComponent } from './components/moves/moves/moves.component';
import { CompareToolComponent } from './components/moves/compare-tool/compare-tool.component';
import { SidenavComponent } from './components/layout/sidenav/sidenav.component';
import { CompareCharactersComponent } from './components/compare/compare-characters/compare-characters.component';
import { CompareCharactersStatTableComponent } from './components/compare/compare-characters-stat-table/compare-characters-stat-table.component';
import { userSettingsReducer } from './store/user-settings/user-settings.reducers';
import { UserSettingsEffects } from './store/user-settings/user-settings.effects';
import { VideoAutoplayMutedDirective } from './directives/video-autoplay-muted.directive';
import { OnlyClientSideDirective } from './directives/only-client-side.directive';
import { MobileOnlyDirective } from './directives/mobile-only.directive';
import { SearchDialogComponent } from './components/search/search-dialog/search-dialog.component';
import { FormsModule } from '@angular/forms';
import { ScriptCommandComponent } from './components/subactions/commands/script-command/script-command.component';
import { AutoCancelCommandComponent } from './components/subactions/commands/auto-cancel-command/auto-cancel-command.component';
import { BodyStateCommandComponent } from './components/subactions/commands/body-state-command/body-state-command.component';
import { HitboxCommandComponent } from './components/subactions/commands/hitbox-command/hitbox-command.component';
import { PartialBodystateCommandComponent } from './components/subactions/commands/partial-bodystate-command/partial-bodystate-command.component';
import { PointerCommandComponent } from './components/subactions/commands/pointer-command/pointer-command.component';
import { StartLoopCommandComponent } from './components/subactions/commands/start-loop-command/start-loop-command.component';
import { ThrowCommandComponent } from './components/subactions/commands/throw-command/throw-command.component';
import { TimerCommandComponent } from './components/subactions/commands/timer-command/timer-command.component';
import { UnsolvedCommandComponent } from './components/subactions/commands/unsolved-command/unsolved-command.component';
import { VisibilityCommandComponent } from './components/subactions/commands/visibility-command/visibility-command.component';

@NgModule({
  declarations: [
    AppComponent,
    MenubarComponent,
    FooterComponent,
    MoveCardComponent,
    CharacterPreviewCardComponent,
    CharacterStatisticsComponent,
    CharactersComponent,
    CharacterComponent,
    MoveListComponent,
    MovesTableComponent,
    CharacterStatisticsTableComponent,
    MoveAttributesListComponent,
    CharacterQuickPickerComponent,
    MoveComponent,
    MoveAttributesTableComponent,
    HitboxesTableComponent,
    MoveGifComponent,
    MovesComponent,
    CompareToolComponent,
    SidenavComponent,
    CompareCharactersComponent,
    CompareCharactersStatTableComponent,
    VideoAutoplayMutedDirective,
    OnlyClientSideDirective,
    MobileOnlyDirective,
    SearchDialogComponent,
    ScriptCommandComponent,
    AutoCancelCommandComponent,
    BodyStateCommandComponent,
    HitboxCommandComponent,
    PartialBodystateCommandComponent,
    PointerCommandComponent,
    StartLoopCommandComponent,
    ThrowCommandComponent,
    TimerCommandComponent,
    UnsolvedCommandComponent,
    VisibilityCommandComponent,
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'serverApp' }),
    AppRoutingModule,
    BrowserAnimationsModule,
    HttpClientModule,
    FormsModule,
    TranslateModule.forRoot({
      defaultLanguage: 'en',
    }),
    StoreModule.forRoot({ frameData: frameDataReducer, userSettings: userSettingsReducer }),
    EffectsModule.forRoot([FrameDataEffects, UserSettingsEffects]),
    SharedModule,
  ],
  providers: [provideClientHydration()],
  bootstrap: [AppComponent],
})
export class AppModule {}
