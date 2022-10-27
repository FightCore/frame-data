import { Component, Input } from '@angular/core';
import { Hitbox } from 'src/app/models/hitbox';
import { select, Store } from '@ngrx/store';
import { isDarkMode } from 'src/app/store/user-settings/user-settings.selectors';

@Component({
  selector: 'app-hitboxes-table',
  templateUrl: './hitboxes-table.component.html',
  styleUrls: ['./hitboxes-table.component.scss'],
})
export class HitboxesTableComponent {
  @Input() hitboxes?: Hitbox[];
  colDef = [
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
  displayedColumns = [
    'name',
    'damage',
    'angle',
    'knockbackGrowth',
    'setKnockback',
    'baseKnockback',
    'effect',
    'hitlagAttacker',
    'hitlagDefender',
    'shieldstun',
  ];

  getValueForHitboxProperty(hitbox: Hitbox, value: string | undefined): string | number {
    if (!value || !hitbox) {
      return '';
    }

    type ObjectKey = keyof typeof hitbox;

    const key = value as ObjectKey;

    return hitbox[key];
  }
}
