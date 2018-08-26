import { TestBed, inject } from '@angular/core/testing';

import { PolizasService } from './polizas.service';

describe('PolizasService', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [PolizasService]
    });
  });

  it('should be created', inject([PolizasService], (service: PolizasService) => {
    expect(service).toBeTruthy();
  }));
});
