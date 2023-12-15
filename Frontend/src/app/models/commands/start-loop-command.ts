import { ScriptCommand } from './script-command';

export interface StartLoopCommand extends ScriptCommand {
  interaction: number;
}
