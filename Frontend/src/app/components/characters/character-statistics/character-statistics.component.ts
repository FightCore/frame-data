import { Component, Input, OnInit } from '@angular/core';
import { FrameDataCharacter } from 'src/app/models/framedata-character';

@Component({
  selector: 'app-character-statistics',
  templateUrl: './character-statistics.component.html',
  styleUrls: ['./character-statistics.component.scss'],
})
export class CharacterStatisticsComponent implements OnInit {
  @Input() frameDataCharacter?: FrameDataCharacter;
  statistics?: any[];
  ngOnInit(): void {
    const stats = this.frameDataCharacter!.characterStatistics;
    this.statistics = [
      { name: 'Weight', value: stats.weight },
      { name: 'Gravity', value: stats.gravity },
      { name: 'Walk speed', value: stats.walkSpeed },
      { name: 'Run speed', value: stats.runSpeed },
      { name: 'Wavedash length rank', value: stats.waveDashLengthRank },
      { name: 'PLA Intangibility frames', value: stats.plaIntangibilityFrames },
      { name: 'Jump squat', value: stats.jumpSquat },
      { name: 'Can wall jump', value: stats.canWallJump ? 'Yes' : 'No' },
      { name: 'Notes', value: stats.notes },
    ].filter((stat) => stat.value !== (null || undefined) && stat.value !== '');
  }

  sortData(event: unknown): void {}
}
