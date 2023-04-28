import { Component, Input, OnInit } from '@angular/core';
import { Character } from 'src/app/models/character';
import { CharacterStatistics } from 'src/app/models/character-statistics';
import { environment } from 'src/environments/environment';
import { Sort } from '@angular/material/sort';

@Component({
  selector: 'app-compare-characters-stat-table',
  templateUrl: './compare-characters-stat-table.component.html',
  styleUrls: ['./compare-characters-stat-table.component.scss'],
})
export class CompareCharactersStatTableComponent implements OnInit {
  @Input() characters: Character[] = [];
  @Input() stat?: string;
  @Input() statTranslationKey: string = '';
  environment = environment;
  sortedValues: CompareData[] = [];
  private values: CompareData[] = [];

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
      this.values.push({
        name: character.name,
        normalizedName: character.normalizedName,
        value: character.characterStatistics[key] as number,
      });
    }

    this.sortedValues = this.values.slice();
  }
  sortData(sort: any) {
    sort = sort as Sort;
    const data = this.values.slice();
    if (!sort.active || sort.direction === '') {
      this.sortedValues = data;
      return;
    }

    this.sortedValues = data.sort((a, b) => {
      const isAsc = sort.direction === 'asc';
      switch (sort.active) {
        case 'name':
          return this.compare(a.name, b.name, isAsc);
        case 'value':
          return this.compare(a.value, b.value, isAsc);
        default:
          return 0;
      }
    });
  }

  compare(a: number | string, b: number | string, isAsc: boolean) {
    return (a < b ? -1 : 1) * (isAsc ? 1 : -1);
  }
}

interface CompareData {
  name: string;
  normalizedName: string;
  value: number;
}
