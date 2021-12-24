export interface IRandomNumberDto {
    alphaCounter: number;
    floatCounter: number;
    numCounter: number;
    fileSize: number;
  }
  export class RandomNumberDto implements IRandomNumberDto {
      alphaCounter: number=0;
      floatCounter: number=0;
      numCounter: number=0;
      fileSize: number=0;
    
  }