import { ScriptCommand } from './script-command';

export interface PartialBodystateCommand extends ScriptCommand {
  bone: number;
}
