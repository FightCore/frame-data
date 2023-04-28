import { Component, OnInit } from '@angular/core';
import { Title } from '@angular/platform-browser';
import { select, Store } from '@ngrx/store';
import { Character } from 'src/app/models/character';
import { CanonicalService } from 'src/app/services/canonical.service';
import { MetaTagService } from 'src/app/services/meta-tag.service';
import { selectCharacters } from 'src/app/store/frame-data/frame-data.selectors';

@Component({
  selector: 'app-characters',
  templateUrl: './characters.component.html',
  styleUrls: ['./characters.component.scss'],
})
export class CharactersComponent implements OnInit {
  characters?: Character[];
  constructor(
    private store: Store,
    private title: Title,
    private meta: MetaTagService,
    private canonicalService: CanonicalService
  ) {
    this.meta.updateForCharacters();
  }

  ngOnInit(): void {
    this.title.setTitle('FightCore');
    this.canonicalService.createLinkForCharacters();
    this.store.pipe(select(selectCharacters())).subscribe((characters) => {
      this.characters = [...characters].sort((a, b) => (a.name > b.name ? 1 : -1));
    });
  }
}
