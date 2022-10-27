import { Component, Input } from '@angular/core';
import { CharacterStatistics } from 'src/app/models/character-statistics';
import { select, Store } from '@ngrx/store';
import { isDarkMode } from 'src/app/store/user-settings/user-settings.selectors';

@Component({
  selector: 'app-character-statistics-table',
  templateUrl: './character-statistics-table.component.html',
  styleUrls: ['./character-statistics-table.component.scss'],
})
export class CharacterStatisticsTableComponent {
  @Input() character?: CharacterStatistics;
  useDarkMode: boolean = false;

  colDefs = [
    { headerName: 'Characters.Attributes.Weight', field: 'weight' },
    {
      headerName: 'Characters.Attributes.Gravity',
      field: 'gravity',
    },
    { headerName: 'Characters.Attributes.WalkSpeed', field: 'walkSpeed' },
    { headerName: 'Characters.Attributes.RunSpeed', field: 'runSpeed' },
    {
      headerName: 'Characters.Attributes.WavedashLengthRank',
      field: 'waveDashLengthRank',
    },
    { headerName: 'Characters.Attributes.JumpSquat', field: 'jumpSquat' },
    { headerName: 'Characters.Attributes.CanWallJump', field: 'canWallJump' }, // ? 'Yes' : 'No' },
    { headerName: 'Characters.Attributes.Notes', field: 'notes' },
  ];
  displayedColumns = [
    'weight',
    'gravity',
    'walkSpeed',
    'runSpeed',
    'waveDashLengthRank',
    'jumpSquat',
    'canWallJump',
    'notes',
  ];

  constructor(private store: Store) {
    this.store.pipe(select(isDarkMode())).subscribe((useDarkMode) => {
      this.useDarkMode = useDarkMode;
    });
  }

  getValueForCharacterProperty(value: string | undefined): string | number | boolean {
    if (!value || !this.character) {
      return '';
    }

    type ObjectKey = keyof typeof this.character;

    const key = value as ObjectKey;

    return this.character[key];
  }
}
