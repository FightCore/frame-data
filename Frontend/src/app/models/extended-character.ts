import { Character } from '@fightcore/models';
import { Subaction } from './subactions/subaction';

export interface ExtendedCharacter extends Character {
  subactions: Subaction[];
}
