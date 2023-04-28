import { Component, Input } from '@angular/core';
import { Store, select } from '@ngrx/store';
import { TranslateService } from '@ngx-translate/core';
import slugify from 'slugify';
import { Character } from 'src/app/models/character';
import { Move } from 'src/app/models/move';
import { isDarkMode } from 'src/app/store/user-settings/user-settings.selectors';

@Component({
  selector: 'app-moves-table',
  templateUrl: './moves-table.component.html',
  styleUrls: ['./moves-table.component.scss'],
})
export class MovesTableComponent {
  @Input() moves?: Move[];
  @Input() character?: Character;
  colDef = [
    { headerName: 'Moves.Attributes.Name', field: 'name' },
    { headerName: 'Moves.Attributes.Start', field: 'start' },
    { headerName: 'Moves.Attributes.End', field: 'end' },
    { headerName: 'Moves.Attributes.IASA', field: 'iasa' },
    {
      headerName: 'Moves.Attributes.TotalFrames',
      field: 'totalFrames',
    },
    {
      headerName: 'Moves.Attributes.LandLag',
      field: 'landLag',
    },
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
  ];
  displayedColumns = [
    'name',
    'start',
    'end',
    'iasa',
    'totalFrames',
    'landLag',
    'lCanceledLandLag',
    'autoCancelBefore',
    'autoCancelAfter',
    'view',
  ];

  getValueForMoveProperty(move: Move, value: string | undefined): string | number | undefined {
    if (!value || !move) {
      return '';
    }

    type ObjectKey = keyof typeof move;

    const key = value as ObjectKey;

    const returnValue = move[key];
    const returnValueType = typeof returnValue;
    if (returnValueType === 'string' || returnValueType === 'number' || returnValueType === 'undefined') {
      return returnValue as string | number | undefined;
    }

    return '';
  }

  moveUrl(move: Move): string {
    return `/characters/${this.character?.id}/${slugify(this.character?.name!)}/moves/${move.id}/${slugify(move.name)}`;
  }
}
