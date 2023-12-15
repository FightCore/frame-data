import { Component } from '@angular/core';
import { StartLoopCommand } from 'src/app/models/commands/start-loop-command';
import { CommandComponent } from '../command.component';

@Component({
  selector: 'app-start-loop-command',
  templateUrl: './start-loop-command.component.html',
  styleUrls: ['./start-loop-command.component.scss'],
})
export class StartLoopCommandComponent extends CommandComponent<StartLoopCommand> {}
