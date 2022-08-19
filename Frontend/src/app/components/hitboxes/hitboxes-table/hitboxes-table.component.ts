import { Component, Input, OnInit } from '@angular/core';
import { TranslateService } from '@ngx-translate/core';
import { ColDef } from 'ag-grid-community';
import { Hitbox } from 'src/app/models/hitbox';
import { TranslatedAgGridTableComponent } from '../../helpers/translated-ag-grid-table';

@Component({
  selector: 'app-hitboxes-table',
  templateUrl: './hitboxes-table.component.html',
  styleUrls: ['./hitboxes-table.component.scss'],
})
export class HitboxesTableComponent extends TranslatedAgGridTableComponent {
  @Input() hitboxes?: Hitbox[];
  colDef: ColDef[] = [
    { headerName: 'Hitboxes.Attributes.Name', field: 'name', pinned: 'left' },
    { headerName: 'Hitboxes.Attributes.Damage', field: 'damage' },
    { headerName: 'Hitboxes.Attributes.Angle', field: 'angle' },
    {
      headerName: 'Hitboxes.Attributes.KnockbackGrowth',
      field: 'knockbackGrowth',
    },
    { headerName: 'Hitboxes.Attributes.SetKnockback', field: 'setKnockback' },
    { headerName: 'Hitboxes.Attributes.BaseKnockback', field: 'baseKnockback' },
    { headerName: 'Hitboxes.Attributes.Effect', field: 'effect' },
    {
      headerName: 'Hitboxes.Attributes.HitlagAttacker',
      field: 'hitlagAttacker',
    },
    {
      headerName: 'Hitboxes.Attributes.HitlagDefender',
      field: 'hitlagDefender',
    },
    { headerName: 'Hitboxes.Attributes.ShieldStun', field: 'shieldstun' },
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
}
