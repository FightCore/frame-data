import { Directive, ElementRef, Inject, OnInit, PLATFORM_ID } from '@angular/core';
import { isPlatformBrowser } from '@angular/common';

@Directive({
  selector: '[appVideoAutoplayMuted]',
})
export class VideoAutoplayMutedDirective implements OnInit {
  constructor(public videoElement: ElementRef, @Inject(PLATFORM_ID) private platformId: any) {}

  ngOnInit(): void {
    if (isPlatformBrowser(this.platformId)) {
      // here is the check
      const video: HTMLVideoElement = this.videoElement.nativeElement;
      video.muted = true;
      video.play();
    }
  }
}
