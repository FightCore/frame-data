import { MatchType } from './match-type';
import { Subaction } from './subaction';

export interface MoveSubaction {
  id: number;
  subaction: Subaction;
  frame: number;
  matchType: MatchType;
}
