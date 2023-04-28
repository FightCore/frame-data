import { Component, OnInit } from '@angular/core';
import { select, Store } from '@ngrx/store';
import { Character } from 'src/app/models/character';
import { CanonicalService } from 'src/app/services/canonical.service';
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
  characters: Character[] = [];
  // Some characters currently don't have known statistics, we want to filter them from this page.
  private filterCharacters = ['fwireframe'];
  constructor(private store: Store, private canonicalService: CanonicalService) {}

  ngOnInit(): void {
    this.canonicalService.createLinkForCompare();
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
