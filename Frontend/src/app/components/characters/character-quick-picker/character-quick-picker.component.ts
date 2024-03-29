import { Component, Input, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { select, Store } from '@ngrx/store';
import slugify from 'slugify';
import { Character } from '@fightcore/models';
import { selectCharacters } from 'src/app/store/frame-data/frame-data.selectors';
import { environment } from 'src/environments/environment';

@Component({
  selector: 'app-character-quick-picker',
  templateUrl: './character-quick-picker.component.html',
  styleUrls: ['./character-quick-picker.component.scss'],
})
export class CharacterQuickPickerComponent implements OnInit {
  characters: Character[] = [];
  specialCharacters: Character[] = [];
  environment = environment;
  private specialCharacterNames: string[] = ['fwireframe'];

  constructor(private router: Router, private store: Store) {}

  ngOnInit(): void {
    this.store.pipe(select(selectCharacters())).subscribe((characters) => {
      for (const character of characters) {
        if (this.specialCharacterNames.includes(character.normalizedName)) {
          this.specialCharacters.push(character);
        } else {
          this.characters.push(character);
        }
      }

      this.characters = this.characters.sort(this.sortCharacters);
      this.specialCharacters = this.specialCharacters.sort(this.sortCharacters);
    });
  }

  sortCharacters(characterOne: Character, characterTwo: Character): number {
    return characterOne.name > characterTwo.name ? 1 : -1;
  }

  viewCharacterUrl(character: Character): string {
    return `/characters/${character.fightCoreId}/${slugify(character.name)}`;
  }
}
