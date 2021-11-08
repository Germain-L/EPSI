class ChessRow:
    def __init__(self, number, pieces):
        self.__number = number
        self.__pieces = pieces

    @property
    def number(self):
        return self.__number
    
    def __str__(self):
        return str(self.__pieces)

    def __len__(self):
        return len(self.__pieces)

    def __getitem__(self, index):
        return self.__pieces[index]

    def __iter__(self):
        '''Returns the next row'''
        return ChessRowIterator(self)


class ChessRowIterator:
    def __init__(self, row):
        self.__row = row
        self.__index = 0

    # Override next method to be able to get the next result of the iterator
    def __next__(self):
        if self.__index < len(self.__row):
            result = self.__row[self.__index]

            self.__index += 1

            return result

        # End of Iteration
        raise StopIteration
