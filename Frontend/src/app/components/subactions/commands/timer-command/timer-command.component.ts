import { Component } from '@angular/core';
import { TimerCommand } from 'src/app/models/commands/timer-command';
import { CommandComponent } from '../command.component';

@Component({
  selector: 'app-timer-command',
  templateUrl: './timer-command.component.html',
  styleUrls: ['./timer-command.component.scss'],
})
export class TimerCommandComponent extends CommandComponent<TimerCommand> {}
