import { Component } from '@angular/core';
import { UnsolvedCommand } from 'src/app/models/commands/unsolved-command';
import { CommandComponent } from '../command.component';

@Component({
  selector: 'app-unsolved-command',
  templateUrl: './unsolved-command.component.html',
  styleUrls: ['./unsolved-command.component.scss'],
})
export class UnsolvedCommandComponent extends CommandComponent<UnsolvedCommand> {}
