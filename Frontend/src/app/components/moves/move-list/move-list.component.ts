import { Component, Input, OnInit } from '@angular/core';
import { Move, MoveType } from '@fightcore/models';

@Component({
  selector: 'app-move-list',
  templateUrl: './move-list.component.html',
  styleUrls: ['./move-list.component.scss'],
})
export class MoveListComponent {
  @Input() moves?: Move[];
  @Input() characterName?: string;
  @Input() characterId?: number;

  moveTypes = [
    { name: 'Moves.Categories.GroundedAttacks', value: MoveType.grounded },
    { name: 'Moves.Categories.TiltAttacks', value: MoveType.tilt },
    { name: 'Moves.Categories.AerialAttacks', value: MoveType.air },
    { name: 'Moves.Categories.SpecialAttacks', value: MoveType.special },
    { name: 'Moves.Categories.Throws', value: MoveType.throw },
    { name: 'Moves.Categories.Dodges', value: MoveType.dodge },
    { name: 'Moves.Categories.Unknown', value: MoveType.unknown },
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
