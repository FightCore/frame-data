import { Component, Input } from '@angular/core';
import { TranslateService } from '@ngx-translate/core';
import { ColDef } from '@ag-grid-community/core';
import { CharacterStatistics } from 'src/app/models/character-statistics';
import { TranslatedAgGridTableComponent } from '../../helpers/translated-ag-grid-table';
import { select, Store } from '@ngrx/store';
import { isDarkMode } from 'src/app/store/user-settings/user-settings.selectors';

@Component({
  selector: 'app-character-statistics-table',
  templateUrl: './character-statistics-table.component.html',
  styleUrls: ['./character-statistics-table.component.scss'],
})
export class CharacterStatisticsTableComponent extends TranslatedAgGridTableComponent {
  @Input() character?: CharacterStatistics;
  useDarkMode: boolean = false;
  defaultColumnDefinition: ColDef = {
    wrapHeaderText: true,
    autoHeaderHeight: true,
    headerValueGetter: (value) => this.translateHeaderName(value),
  };
  colDefs: ColDef[] = [
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
  constructor(translateService: TranslateService, private store: Store) {
    super(translateService);

    this.store.pipe(select(isDarkMode())).subscribe((useDarkMode) => {
      this.useDarkMode = useDarkMode;
    });
  }

  onGridReady() {
    this.agGrid?.api.sizeColumnsToFit();
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
