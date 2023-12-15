import { ScriptCommand } from '../commands/script-command';

export interface Subaction {
  id: number;
  index: number;
  name: string;
  commands: ScriptCommand[];
}
