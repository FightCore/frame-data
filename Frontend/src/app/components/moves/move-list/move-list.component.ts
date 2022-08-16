import { Component, Input, OnInit } from '@angular/core';
import { Move } from 'src/app/models/move';
import { MoveType } from 'src/app/models/move-type';

@Component({
  selector: 'app-move-list',
  templateUrl: './move-list.component.html',
  styleUrls: ['./move-list.component.scss'],
})
export class MoveListComponent {
  @Input() moves?: Move[];
  @Input() characterName?: string;

  moveTypes = [
    { name: 'Grounded attacks', value: MoveType.grounded },
    { name: 'Tilt attacks', value: MoveType.tilt },
    { name: 'Aerial attacks', value: MoveType.air },
    { name: 'Special attacks', value: MoveType.special },
    { name: 'Throws', value: MoveType.throw },
    { name: 'Dodges', value: MoveType.dodge },
    { name: 'Unknown', value: MoveType.unknown },
  ];

  getMovesForType(moveType: MoveType): Move[] {
    if (!this.moves) {
      return [];
    }

    return this.moves
      .filter((move) => move.type === moveType)
      .sort((moveA, moveB) => moveA.name.localeCompare(moveB.name));
  }
}
