import { Component, OnInit } from '@angular/core';
import { Title } from '@angular/platform-browser';
import { select, Store } from '@ngrx/store';
import { FrameDataCharacter } from 'src/app/models/framedata-character';
import { MetaTagService } from 'src/app/services/meta-tag.service';
import { selectCharacters } from 'src/app/store/frame-data/frame-data.selectors';

@Component({
  selector: 'app-characters',
  templateUrl: './characters.component.html',
  styleUrls: ['./characters.component.scss'],
})
export class CharactersComponent implements OnInit {
  characters?: FrameDataCharacter[];
  constructor(private store: Store, private title: Title, private meta: MetaTagService) {
    this.meta.updateForCharacters();
  }

  ngOnInit(): void {
    this.title.setTitle('Characters - FightCore');
    this.store.pipe(select(selectCharacters())).subscribe((characters) => {
      this.characters = [...characters].sort((a, b) => (a.name > b.name ? 1 : -1));
    });
  }
}
