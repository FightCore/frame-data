import { Component, Input, OnInit } from '@angular/core';
import { TranslateService } from '@ngx-translate/core';
import { ColDef } from '@ag-grid-community/core';
import { Move } from 'src/app/models/move';
import { TranslatedAgGridTableComponent } from '../../helpers/translated-ag-grid-table';

@Component({
  selector: 'app-move-attributes-table',
  templateUrl: './move-attributes-table.component.html',
  styleUrls: ['./move-attributes-table.component.scss'],
})
export class MoveAttributesTableComponent extends TranslatedAgGridTableComponent {
  @Input() move?: Move;
  colDef: ColDef[] = [
    { headerName: 'Moves.Attributes.Start', field: 'start' },
    { headerName: 'Moves.Attributes.End', field: 'end' },
    { headerName: 'Moves.Attributes.TotalFrames', field: 'totalFrames' },
    { headerName: 'Moves.Attributes.IASA', field: 'iasa' },
    { headerName: 'Moves.Attributes.LandLag', field: 'landLag' },
    {
      headerName: 'Moves.Attributes.LCanceledLandLag',
      field: 'lCanceledLandLang',
    },
    {
      headerName: 'Moves.Attributes.AutoCancelBefore',
      field: 'autoCancelBefore',
    },
    {
      headerName: 'Moves.Attributes.AutoCancelAfter',
      field: 'autoCancelAfter',
    },
  ];
  defaultColDef: ColDef = {
    headerValueGetter: (value) => this.translateHeaderName(value),
  };
  constructor(translateService: TranslateService) {
    super(translateService);
  }

  onGridReady(): void {
    this.agGrid?.api.sizeColumnsToFit();
  }

  getValueForMoveProperty(value: string | undefined): string | number | undefined {
    if (!value || !this.move) {
      return '';
    }

    type ObjectKey = keyof typeof this.move;

    const key = value as ObjectKey;

    const returnValue = this.move[key];
    const returnValueType = typeof returnValue;
    if (returnValueType === 'string' || returnValueType === 'number' || returnValueType === 'undefined') {
      return returnValue as string | number | undefined;
    }

    return '';
  }
}
