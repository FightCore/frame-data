import { Move } from '@fightcore/models';
import { MoveSubaction } from './subactions/move-subaction';

export interface ExtendedMove extends Move {
  moveSubactions: MoveSubaction[];
}
