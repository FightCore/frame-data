import { Component, Input } from '@angular/core';
import { Move } from '@fightcore/models';
import { select, Store } from '@ngrx/store';
import { isDarkMode } from 'src/app/store/user-settings/user-settings.selectors';

@Component({
  selector: 'app-move-attributes-table',
  templateUrl: './move-attributes-table.component.html',
  styleUrls: ['./move-attributes-table.component.scss'],
})
export class MoveAttributesTableComponent {
  @Input() move?: Move;
  colDef = [
    { headerName: 'Moves.Attributes.Start', field: 'start' },
    { headerName: 'Moves.Attributes.End', field: 'end' },
    { headerName: 'Moves.Attributes.TotalFrames', field: 'totalFrames' },
    { headerName: 'Moves.Attributes.IASA', field: 'iasa' },
    { headerName: 'Moves.Attributes.LandLag', field: 'landLag' },
    {
      headerName: 'Moves.Attributes.LCanceledLandLag',
      field: 'lCanceledLandLag',
    },
    {
      headerName: 'Moves.Attributes.AutoCancelBefore',
      field: 'autoCancelBefore',
    },
    {
      headerName: 'Moves.Attributes.AutoCancelAfter',
      field: 'autoCancelAfter',
    },
    {
      headerName: 'Moves.Attributes.LandingFallSpecialLag',
      field: 'landingFallSpecialLag',
    },
  ];
  displayedColumns = [
    'start',
    'end',
    'totalFrames',
    'iasa',
    'landLag',
    'lCanceledLandLag',
    'landingFallSpecialLag',
    'autoCancelBefore',
    'autoCancelAfter',
  ];

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
