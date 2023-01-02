import { MediaMatcher } from '@angular/cdk/layout';
import { isPlatformBrowser } from '@angular/common';
import {
  ChangeDetectorRef,
  Directive,
  Inject,
  OnChanges,
  OnInit,
  PLATFORM_ID,
  SimpleChanges,
  TemplateRef,
  ViewContainerRef,
} from '@angular/core';

@Directive({
  selector: '[appMobileOnly]',
})
export class MobileOnlyDirective implements OnInit {
  mobileQuery?: MediaQueryList;

  private _mobileQueryListener?: () => void;

  constructor(
    @Inject(PLATFORM_ID) platformId: string,
    media: MediaMatcher,
    private templateRef: TemplateRef<any>,
    private viewContainer: ViewContainerRef
  ) {
    if (isPlatformBrowser(platformId)) {
      this.mobileQuery = media.matchMedia('(max-width: 600px)');
      this._mobileQueryListener = this.checkMobileQuery.bind(this);
      this.mobileQuery.addListener(this._mobileQueryListener);
    }
  }
  ngOnInit(): void {
    this.checkMobileQuery();
  }

  private checkMobileQuery(): void {
    if (this.mobileQuery && this.mobileQuery.matches) {
      this.viewContainer.createEmbeddedView(this.templateRef);
    } else {
      this.viewContainer.clear();
    }
  }
}
