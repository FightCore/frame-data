import { Component, Input } from '@angular/core';
import { TranslateService } from '@ngx-translate/core';
import { ColDef, ColGroupDef } from 'ag-grid-community';
import { Move } from 'src/app/models/move';
import { TranslatedAgGridTableComponent } from '../../helpers/translated-ag-grid-table';

@Component({
  selector: 'app-moves-table',
  templateUrl: './moves-table.component.html',
  styleUrls: ['./moves-table.component.scss'],
})
export class MovesTableComponent extends TranslatedAgGridTableComponent {
  @Input() moves?: Move[];
  colDef: (ColDef | ColGroupDef)[] = [
    { headerName: 'Moves.Attributes.Name', field: 'name', pinned: 'left' },
    {
      headerName: 'Moves.Attributes.Frames',
      headerValueGetter: (value) => this.translateHeaderName(value),
      children: [
        { headerName: 'Moves.Attributes.Start', field: 'start' },
        { headerName: 'Moves.Attributes.End', field: 'end' },
        { headerName: 'Moves.Attributes.IASA', field: 'iasa' },
        {
          headerName: 'Moves.Attributes.TotalFrames',
          field: 'totalFrames',
        },
      ],
    },
    {
      headerName: 'Moves.Attributes.LandLag',
      headerValueGetter: (value) => this.translateHeaderName(value),
      children: [
        {
          headerName: 'Moves.Attributes.LandLag',
          field: 'landLag',
        },
        {
          headerName: 'Moves.Attributes.LCanceledLandLag',
          field: 'lCanceledLandLang',
        },
      ],
    },
    {
      headerName: 'Moves.Attributes.AutoCancel',
      headerValueGetter: (value) => this.translateHeaderName(value),
      children: [
        {
          headerName: 'Moves.Attributes.AutoCancelBefore',
          field: 'autoCancelBefore',
        },
        {
          headerName: 'Moves.Attributes.AutoCancelAfter',
          field: 'autoCancelAfter',
        },
      ],
    },
    {
      headerName: 'Moves.Attributes.Etc',
      headerValueGetter: (value) => this.translateHeaderName(value),
      children: [
        {
          headerName: 'Moves.Attributes.DatabaseName',
          field: 'normalizedName',
        },
        { headerName: 'Common.Notes', field: 'notes' },
        {
          headerName: 'Common.Source',
          field: 'source',
        },
      ],
    },
  ];
  defaultColumnDefinitions?: ColDef = {
    sortable: true,
    filter: true,
    autoHeaderHeight: true,
    wrapHeaderText: true,
    headerValueGetter: (value) => this.translateHeaderName(value),
  };
  constructor(translateService: TranslateService) {
    super(translateService);
  }

  onGridReady(): void {
    this.agGrid?.columnApi.autoSizeAllColumns();
  }
}
