import { Component, OnInit } from '@angular/core';
import { TranslateService } from '@ngx-translate/core';
import { Store } from '@ngrx/store';
import * as FrameDataActions from 'src/app/store/frame-data/frame-data.actions';
import { Meta } from '@angular/platform-browser';
import { MetaTagService } from './services/meta-tag.service';
import { NavigationEnd, NavigationStart, Router } from '@angular/router';
import { filter } from 'rxjs';
@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss'],
})
export class AppComponent {
  title = 'FightCore';

  constructor(
    translateService: TranslateService,
    store: Store,
    private meta: Meta,
    private metaTagService: MetaTagService,
    private router: Router
  ) {
    // this language will be used as a fallback when a translation isn't found in the current language
    translateService.setDefaultLang('en');

    // the lang to use, if the lang isn't available, it will use the current loader to get them
    translateService.use('en');
    store.dispatch(FrameDataActions.loadCharacters());

    this.router.events.pipe(filter((event) => event instanceof NavigationStart)).subscribe(() => {
      this.metaTagService.removeAllTags();
      this.meta.addTags([
        { name: 'title', content: 'FightCore' },
        { name: 'description', content: 'FightCore is the frame data website for Super Smash Bros. Melee' },
        {
          name: 'keywords',
          content: 'FightCore, frame data, melee, smash, frames, hitlag, ssbm, melee frame data, melee hitboxes',
        },
        { name: 'twitter.card', content: 'summary' },
        { name: 'twitter:title', content: 'FightCore' },
        { name: 'twitter:description', content: 'FightCore is the frame data website for Super Smash Bros. Melee' },
        { name: 'twitter:site', content: 'https://fightcore.gg' },
        { name: 'twitter:author', content: '@BortTheBeaver' },
        { name: 'og:title', content: 'FightCore' },
        { name: 'og:description', content: 'FightCore is the frame data website for Super Smash Bros. Melee' },
        { name: 'og:url', content: 'https://fightcore.gg' },
        { name: 'og:type', content: 'website' },
        { name: 'theme-color', content: '#96153a' },
      ]);
    });
  }
}
