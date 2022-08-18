import { Component, Input, OnInit, ViewChild } from '@angular/core';
import { TranslateService } from '@ngx-translate/core';
import { AgGridAngular } from 'ag-grid-angular';
import { ColDef, HeaderValueGetterParams } from 'ag-grid-community';
import { CharacterStatistics } from 'src/app/models/character-statistics';

@Component({
  selector: 'app-character-statistics-table',
  templateUrl: './character-statistics-table.component.html',
  styleUrls: ['./character-statistics-table.component.scss'],
})
export class CharacterStatisticsTableComponent implements OnInit {
  @ViewChild(AgGridAngular) agGrid!: AgGridAngular;
  @Input() character?: CharacterStatistics;
  defaultColumnDefinition: ColDef = {
    wrapHeaderText: true,
    autoHeaderHeight: true,
    headerValueGetter: (value: HeaderValueGetterParams) =>
      this.translateService.instant(value.colDef.headerName as string),
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
  constructor(private translateService: TranslateService) {
    this.translateService.onLangChange.subscribe(() => {
      this.agGrid?.api.refreshHeader();
    });
  }

  onGridReady() {
    this.agGrid.api.sizeColumnsToFit();
  }
  ngOnInit(): void {}
}
