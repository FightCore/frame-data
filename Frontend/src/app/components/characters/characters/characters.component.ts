import { Component, OnInit } from '@angular/core';
import { Title } from '@angular/platform-browser';
import { Router } from '@angular/router';
import { select, Store } from '@ngrx/store';
import { FrameDataCharacter } from 'src/app/models/framedata-character';
import { FrameDataService } from 'src/app/services/frame-data.service';
import { selectCharacters } from 'src/app/store/frame-data/frame-data.selectors';

@Component({
  selector: 'app-characters',
  templateUrl: './characters.component.html',
  styleUrls: ['./characters.component.scss'],
})
export class CharactersComponent implements OnInit {
  characters?: FrameDataCharacter[];
  constructor(private store: Store, private title: Title) {}

  ngOnInit(): void {
    this.title.setTitle('Characters - FightCore');
    this.store.pipe(select(selectCharacters())).subscribe((characters) => {
      this.characters = [...characters].sort((a, b) => (a.name > b.name ? 1 : -1));
    });
  }
}
