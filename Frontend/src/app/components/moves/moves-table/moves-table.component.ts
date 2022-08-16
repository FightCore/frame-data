import { Component, Input, OnInit, ViewChild } from '@angular/core';
import { AgGridAngular } from 'ag-grid-angular';
import { ColDef, ColGroupDef } from 'ag-grid-community';
import { Move } from 'src/app/models/move';

@Component({
  selector: 'app-moves-table',
  templateUrl: './moves-table.component.html',
  styleUrls: ['./moves-table.component.scss'],
})
export class MovesTableComponent implements OnInit {
  @ViewChild(AgGridAngular) agGrid!: AgGridAngular;
  @Input() moves?: Move[];
  colDef?: (ColDef | ColGroupDef)[];
  defaultColumnDefinitions?: ColDef = {
    sortable: true,
    filter: true,
    autoHeaderHeight: true,
    wrapHeaderText: true,
  };
  constructor() {
    this.colDef = [
      { headerName: 'Name', field: 'name', pinned: 'left' },
      {
        headerName: 'Frames',
        children: [
          { headerName: 'Start', field: 'start' },
          { headerName: 'End', field: 'end' },
          { headerName: 'IASA', field: 'iasa' },
          {
            headerName: 'Total Frames',
            field: 'totalFrames',
          },
        ],
      },
      {
        headerName: 'Land Lag',
        children: [
          {
            headerName: 'Land lag',
            field: 'landLag',
          },
          {
            headerName: 'L-Canceled Land lag',
            field: 'lCanceledLandLang',
          },
        ],
      },
      {
        headerName: 'Auto cancel',
        children: [
          {
            headerName: 'Auto cancel before',
            field: 'autoCancelBefore',
          },
          {
            headerName: 'Auto cancel after',
            field: 'autoCancelAfter',
          },
        ],
      },
      {
        headerName: 'Etc',
        children: [
          { headerName: 'Technical Name', field: 'normalizedName' },
          { headerName: 'Notes', field: 'notes' },
          {
            headerName: 'Source',
            field: 'source',
          },
        ],
      },
    ];
  }

  onGridReady(): void {
    this.agGrid.columnApi.autoSizeAllColumns();
  }

  ngOnInit(): void {}
}
