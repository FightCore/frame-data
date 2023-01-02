import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { TranslateLoader, TranslateModule } from '@ngx-translate/core';
import { TranslateHttpLoader } from '@ngx-translate/http-loader';
import { HttpClient, HttpClientModule } from '@angular/common/http';
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
import { environment } from 'src/environments/environment';
import { CompareCharactersComponent } from './components/compare/compare-characters/compare-characters.component';
import { CompareCharactersStatTableComponent } from './components/compare/compare-characters-stat-table/compare-characters-stat-table.component';
import { userSettingsReducer } from './store/user-settings/user-settings.reducers';
import { UserSettingsEffects } from './store/user-settings/user-settings.effects';
import { VideoAutoplayMutedDirective } from './directives/video-autoplay-muted.directive';
import { OnlyClientSideDirective } from './directives/only-client-side.directive';
import { MobileOnlyDirective } from './directives/mobile-only.directive';

export function createTranslateLoader(http: HttpClient) {
  return new TranslateHttpLoader(http, environment.siteUrl + '/assets/i18n/', '.json');
}

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
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'serverApp' }),
    AppRoutingModule,
    BrowserAnimationsModule,
    HttpClientModule,
    TranslateModule.forRoot({
      loader: {
        provide: TranslateLoader,
        useFactory: createTranslateLoader,
        deps: [HttpClient],
      },
      defaultLanguage: 'en',
    }),
    StoreModule.forRoot({ frameData: frameDataReducer, userSettings: userSettingsReducer }),
    EffectsModule.forRoot([FrameDataEffects, UserSettingsEffects]),
    SharedModule,
  ],
  providers: [],
  bootstrap: [AppComponent],
})
export class AppModule {}
