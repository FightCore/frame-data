import { Component, OnInit } from '@angular/core';
import { select, Store } from '@ngrx/store';
import { FrameDataCharacter } from 'src/app/models/framedata-character';
import { selectCharacters } from 'src/app/store/frame-data/frame-data.selectors';

@Component({
  selector: 'app-compare-characters',
  templateUrl: './compare-characters.component.html',
  styleUrls: ['./compare-characters.component.scss'],
})
export class CompareCharactersComponent implements OnInit {
  stats = [
    { key: 'weight', translation: 'Characters.Attributes.Weight' },
    { key: 'walkSpeed', translation: 'Characters.Attributes.WalkSpeed' },
    { key: 'gravity', translation: 'Characters.Attributes.Gravity' },
    { key: 'runSpeed', translation: 'Characters.Attributes.RunSpeed' },
    { key: 'waveDashLengthRank', translation: 'Characters.Attributes.WavedashLengthRank' },
    { key: 'plaIntangibilityFrames', translation: 'Characters.Attributes.PLAIntangibilityFrames' },
    { key: 'jumpSquat', translation: 'Characters.Attributes.JumpSquat' },
  ];
  characters: FrameDataCharacter[] = [];
  // Some characters currently don't have known statistics, we want to filter them from this page.
  private filterCharacters = ['fwireframe'];
  constructor(private store: Store) {}

  ngOnInit(): void {
    this.store
      .pipe(select(selectCharacters()))
      .subscribe(
        (characters) =>
          (this.characters = characters.filter(
            (character) => !this.filterCharacters.includes(character.normalizedName)
          ))
      );
  }
}