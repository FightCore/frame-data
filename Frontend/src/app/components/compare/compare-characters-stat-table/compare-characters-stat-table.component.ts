import { Component, Input, OnInit } from '@angular/core';
import { FrameDataCharacter } from 'src/app/models/framedata-character';
import { CharacterStatistics } from 'src/app/models/character-statistics';
import { environment } from 'src/environments/environment';

@Component({
  selector: 'app-compare-characters-stat-table',
  templateUrl: './compare-characters-stat-table.component.html',
  styleUrls: ['./compare-characters-stat-table.component.scss'],
})
export class CompareCharactersStatTableComponent implements OnInit {
  @Input() characters: FrameDataCharacter[] = [];
  @Input() stat?: string;
  @Input() statTranslationKey: string = '';
  environment = environment;
  values: Map<FrameDataCharacter, string> = new Map<FrameDataCharacter, string>();
  constructor() {}

  ngOnInit(): void {
    if (!this.stat) {
      throw new Error('Stat is undefined for the compare table.');
    }

    type keys = keyof CharacterStatistics;
    const key = this.stat as keys;
    this.characters = [...this.characters].sort((characterA, characterB) =>
      characterA.characterStatistics[key] < characterB.characterStatistics[key] ? 1 : -1
    );
    for (const character of this.characters) {
      this.values.set(character, character.characterStatistics[key].toString());
    }
  }
}
