import { ScriptCommand } from './script-command';

export interface TimerCommand extends ScriptCommand {
  frames: number;
}
