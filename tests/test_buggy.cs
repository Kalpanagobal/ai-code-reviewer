import pytest
# from buggy.cs import YourClass

def test_happy_path():
    # Arrange
    expected = ...
    # Act
    result = ...  # call your function here
    # Assert
    assert result == expected

def test_edge_case_zero():
    # Test division by zero / boundary conditions
    with pytest.raises(ValueError):
        ...  # call with invalid input
