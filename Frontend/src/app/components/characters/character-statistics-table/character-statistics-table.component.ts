import { Component, Input, OnInit, ViewChild } from '@angular/core';
import { TranslateService } from '@ngx-translate/core';
import { AgGridAngular } from 'ag-grid-angular';
import { ColDef, HeaderValueGetterParams } from 'ag-grid-community';
import { CharacterStatistics } from 'src/app/models/character-statistics';
import { TranslatedAgGridTableComponent } from '../../helpers/translated-ag-grid-table';

@Component({
  selector: 'app-character-statistics-table',
  templateUrl: './character-statistics-table.component.html',
  styleUrls: ['./character-statistics-table.component.scss'],
})
export class CharacterStatisticsTableComponent extends TranslatedAgGridTableComponent {
  @Input() character?: CharacterStatistics;
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
  constructor(translateService: TranslateService) {
    super(translateService);
  }

  onGridReady() {
    this.agGrid?.columnApi.autoSizeAllColumns();
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
