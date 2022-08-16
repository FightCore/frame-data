import { Component, Input, OnInit, ViewChild } from '@angular/core';
import { AgGridAngular } from 'ag-grid-angular';
import { ColDef } from 'ag-grid-community';
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
  };
  colDefs: ColDef[] = [
    { headerName: 'Weight', field: 'weight' },
    { headerName: 'Gravity', field: 'gravity' },
    { headerName: 'Walk speed', field: 'walkSpeed' },
    { headerName: 'Run speed', field: 'runSpeed' },
    { headerName: 'Wavedash length rank', field: 'waveDashLengthRank' },
    { headerName: 'PLA Intangibility frames', field: 'plaIntangibilityFrames' },
    { headerName: 'Jump squat', field: 'jumpSquat' },
    { headerName: 'Can wall jump', field: 'canWallJump' }, // ? 'Yes' : 'No' },
    { headerName: 'Notes', field: 'notes' },
  ];
  constructor() {}

  onGridReady() {
    this.agGrid.api.sizeColumnsToFit();
  }
  ngOnInit(): void {}
}
