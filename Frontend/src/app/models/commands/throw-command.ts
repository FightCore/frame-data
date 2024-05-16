import { ScriptCommand } from './script-command';
import { ThrowElementType } from './throw-element-type';
import { ThrowType } from './throw-type';

export interface ThrowCommand extends ScriptCommand {
  throwType: ThrowType;
  damage: number;
  knockbackGrowth: number;
  weightDependantKnockback: number;
  throwElement: ThrowElementType;
  angle: number;
  baseKnockback: number;
}
