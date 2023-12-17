import { MediaMatcher } from '@angular/cdk/layout';
import { isPlatformBrowser } from '@angular/common';
import { ChangeDetectorRef, Component, Inject, OnInit, PLATFORM_ID } from '@angular/core';
import { Title } from '@angular/platform-browser';
import { ActivatedRoute } from '@angular/router';
import { select, Store } from '@ngrx/store';
import { Character, MoveType } from '@fightcore/models';
import { CanonicalService } from 'src/app/services/canonical.service';
import { MetaTagService } from 'src/app/services/meta-tag.service';
import { selectCharacter } from 'src/app/store/frame-data/frame-data.selectors';
import { ExtendedCharacter } from 'src/app/models/extended-character';
import { expandCharacter } from 'src/app/store/frame-data/frame-data.actions';
import { filter } from 'rxjs';

@Component({
  selector: 'app-character',
  templateUrl: './character.component.html',
  styleUrls: ['./character.component.scss'],
})
export class CharacterComponent implements OnInit {
  character?: ExtendedCharacter;
  mobileQuery?: MediaQueryList;

  private _mobileQueryListener?: () => void;

  moveTypes = [
    { name: 'Moves.Categories.GroundedAttacks', value: MoveType.grounded },
    { name: 'Moves.Categories.TiltAttacks', value: MoveType.tilt },
    { name: 'Moves.Categories.AerialAttacks', value: MoveType.air },
    { name: 'Moves.Categories.SpecialAttacks', value: MoveType.special },
    { name: 'Moves.Categories.Throws', value: MoveType.throw },
    { name: 'Moves.Categories.Dodges', value: MoveType.dodge },
    { name: 'Moves.Categories.Unknown', value: MoveType.unknown },
  ];
  constructor(
    @Inject(PLATFORM_ID) platformId: string,
    changeDetectorRef: ChangeDetectorRef,
    media: MediaMatcher,
    private store: Store,
    private activatedRoute: ActivatedRoute,
    private metaTagService: MetaTagService,
    private title: Title,
    private canonicalService: CanonicalService
  ) {
    if (isPlatformBrowser(platformId)) {
      this.mobileQuery = media.matchMedia('(max-width: 600px)');
      this._mobileQueryListener = () => changeDetectorRef.detectChanges();
      this.mobileQuery.addListener(this._mobileQueryListener);
    }
  }

  ngOnInit(): void {
    this.activatedRoute.paramMap.subscribe((paramMap) => {
      const characterId = paramMap.get('characterId');
      if (!characterId) {
        return;
      }
      this.store.dispatch(expandCharacter({ fightCoreId: parseFloat(characterId) }));
      this.store
        .select(selectCharacter({ characterId: parseFloat(characterId) }))
        .pipe(filter((character) => character !== null && character !== undefined))
        .subscribe((character) => {
          this.character = character;
          if (character) {
            this.metaTagService.updateCharacterMetaTags(character);
            this.title.setTitle(`${character.name} | FightCore - Melee Frame Data`);
            this.canonicalService.createLinkForCharacter(character);
          }
        });
    });
  }

  navigateToCategory(value: number): void {
    const el = document.getElementById('category-' + value);
    if (el) {
      el.scrollIntoView({ behavior: 'smooth' });
    }
  }

  navigateToSection(value: string): void {
    const el = document.getElementById('section-' + value);
    if (el) {
      el.scrollIntoView({ behavior: 'smooth' });
    }
  }
}
