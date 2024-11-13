import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CardSorterComponent } from './card-sorter.component';

describe('CardSorterComponent', () => {
  let component: CardSorterComponent;
  let fixture: ComponentFixture<CardSorterComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [CardSorterComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(CardSorterComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
